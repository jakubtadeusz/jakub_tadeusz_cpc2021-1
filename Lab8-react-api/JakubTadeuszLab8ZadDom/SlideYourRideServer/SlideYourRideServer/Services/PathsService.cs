using SlideYourRideServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlideYourRideServer.Services
{
    public class PathsService : IPathsService
    {
        private readonly DatabaseContext _context;

        public PathsService(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Zwraca ścieżkę na podstawie algorytmu Dijkstry
        /// </summary>
        /// <param name="stopId"></param>
        /// <returns></returns>
        public Paths Get(int stopId)
        {
            // Załadowanie przystanków z bazy danych
            var stops = _context.Stops.ToArray();

            // Utworzenie odpowiednich tablic

            // Droga od wierzchołka początkowego
            int[] distance = new int[stops.Length];
            // Poprzedni wierzchołek
            int[] previous = new int[stops.Length];
            // Klucze główne z bazy danych
            int[] realId = new int[stops.Length];
            // Informacja czy wierzchołek został już sprawdzony
            bool[] visited = new bool[stops.Length];

            bool validId = false;

            for (int i = 0; i < stops.Length; i++)
            {
                if (stops[i].Id.Equals(stopId))
                {
                    // Znalezienie w naszej tablicy przystanków rekordu w tablicy z identyfikatorem odpowiadającym wybranemu
                    stopId = i;
                    // Potwierdzenie znalezienia elementu w tablicy
                    validId = true;
                }
                // Ustawienie wartości początkowych
                distance[i] = Int32.MaxValue;
                previous[i] = -1;
                visited[i] = false;
                realId[i] = stops[i].Id;
            }

            // Gdy Id jest nieprawidłowe, kończymy funkcję
            if (!validId) return null;

            // Ustalamy dystans do wierzchołka początkowego na 0
            distance[stopId] = 0;

            // Wykonujemy odpowiednią ilośc iteracji
            for(int i = 0; i < stops.Length-1; i++)
            {
                int u = -1;

                // Znajdujemy wierzchołek, do którego droga jest najkrótsza i który nie został jeszcze sprawdzony
                int minDist = Int32.MaxValue;
                for(int j = 0; j < stops.Length; j++)
                {
                    if(!visited[j]&&distance[j] < minDist)
                    {
                        minDist = distance[j];
                        u = j;
                    }
                }
                if (u != -1)
                {
                    // Oznaczamy wybrany wierzchołek jako sprawdzony
                    visited[u] = true;
                    // Pobieramy z bazy danych krawędzie wychodzące z wierzchołka
                    var vertices = _context.Tracks.Where((t)=>t.StartStopId.Equals(stops[u].Id));
                    foreach (var vertice in vertices)
                    {
                        // Wyszukujemy Id odpowiadające naszym kluczom głównym
                        int startId = -1;
                        int endId = -1;
                        for(int k = 0; k < stops.Length; k++)
                        {
                            if (realId[k].Equals(vertice.StartStopId))
                                startId = k;
                            if (realId[k].Equals(vertice.EndStopId))
                                endId = k;
                        }

                        // Dokonujemy relaksacji
                        if (!visited[endId] && distance[endId] > distance[startId] + vertice.Length)
                        {
                            distance[endId] = (distance[startId] + vertice.Length);
                            previous[endId] = startId;
                        }

                    }
                }
            }

            // Zwracamy obiekt Paths
            return new Paths {StartId =  stops[stopId].Id, Distance = distance, Previous = previous, DbId = realId};
        }
    }
}
