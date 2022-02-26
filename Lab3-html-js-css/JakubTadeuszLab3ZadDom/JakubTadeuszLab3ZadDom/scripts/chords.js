
let slideIndex = 1;

function NextSlide() {
    slideIndex++;
    ShowSlides();
}

function PrevSlide() {
    slideIndex--;
    ShowSlides();
}

function CurrentSlide(n) {
    slideIndex = n
    ShowSlides();
}

function ShowSlides() {
    var i;
    var slides = document.getElementsByClassName("chordSlides");
    var dots = document.getElementsByClassName("dot");
    if (slideIndex > slides.length) { slideIndex = 1 }
    if (slideIndex < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "flex";
    dots[slideIndex - 1].className += " active";
}

function RunMetronome(array) {
    window.sessionStorage.setItem("metronomeArray", JSON.stringify(array));
    let a = document.createElement('a');
    a.href = 'metronome.html';
    a.click();
}

function LoadChords() {
    let chords = {
        "D": [-1, -1, 0, 2, 3, 2],
        "A": [-1, 0, 2, 2, 2, 0],
        "E": [0, 2, 2, 1, 0, 0],
        "Am": [-1, 0, 2, 2, 1, 0],
        "Em": [0, 2, 2, 0, 0, 0],
        "Dm": [-1, -1, 0, 2, 3, 1],
        "G": [3, 2, 0, 0, 0, 3],
        "C": [-1, 3, 2, 0, 1, 0]
    };
    let userChords = JSON.parse(window.localStorage.getItem("userChords"));
    if (userChords != null) {
        for (let key of Object.keys(userChords)) {
            chords[key] = userChords[key];
        }
    }
    $("#chords-slideshow").append("<a class='prev' onclick='PrevSlide()'>&#10094;</a>");
    let i = 1;
    let canvas
    for (let key of Object.keys(chords)) {
        $("#chord-dots").append("<span class='dot' onclick='CurrentSlide(" + i + ")'>" + key + "</span>")
        $("#chords-slideshow").append("<div class='chordSlides fade'><canvas id = '" + key + "'  width='200' height='320'></canvas></div >");
        canvas = document.getElementById(key);
        markedFrets = chords[key];
        PrintChord(canvas);
        i++;
    }
    $("#chords-slideshow").append(" <a class='next' onclick='NextSlide()'>&#10095;</a>");
    CurrentSlide(1);
}