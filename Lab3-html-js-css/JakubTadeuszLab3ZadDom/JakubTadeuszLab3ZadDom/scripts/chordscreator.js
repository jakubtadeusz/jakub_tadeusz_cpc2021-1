
let markedFrets = [];

function SetupChordsCreatorCanvas() {
    let canvas = document.getElementById("chords-creator");
    SetAllStringsOpen(6);
    PrintChord(canvas);
    canvas.addEventListener("click", function (e) {
        let rect = canvas.getBoundingClientRect();
        let x = event.clientX - rect.left;
        let y = event.clientY - rect.top;
        AddFretMarker(canvas, 6, x, y);
    });
}

function AddFretMarker(canvas, stringsAmount, x, y) {
    let fretDistance = (canvas.height - canvas.height / 8) / stringsAmount;
    let stringDistance = (canvas.width - canvas.width / 5) / (stringsAmount - 1);
    let string = Math.floor(x / stringDistance);
    let fret = Math.floor((y) / fretDistance);
    if (fret == 6) {
        fret = 5;
    }
    if (fret == 0 && markedFrets[string] == 0) {
        fret = -1;
    }
    markedFrets[string] = fret;
    PrintChord(canvas);
}

function PrintChord(canvas) {
    let context = canvas.getContext("2d");
    context.clearRect(0, 0, canvas.width, canvas.height);
    context.fillStyle = "white";
    context.fillRect(0, 0, canvas.width, canvas.height);
    DrawFrets(5, context, canvas.width, canvas.height);
    let stringSizes = [4.6, 3.6, 2.6, 1.7, 1.3, 1.0];
    DrawStrings(stringSizes, context, canvas.width, canvas.height);
    DrawFretMarkers(6, context, canvas.width, canvas.height);
}

function DrawNut(context, width, height) {
    context.fillStyle = "black";
    context.fillRect(width/10 -2, height/16, width * 0.8 + 5, height/64);
}

function DrawFrets(amount, context, width, height) {
    DrawNut(context, width, height);
    context.fillStyle = "grey";
    let fretDistance = (height - height / 8) / amount;
    let fretPosition = height / 16;
    for (let i = 0; i < amount; i++) {
        fretPosition += fretDistance;
        context.fillRect(width / 10 -2, fretPosition, width * 0.8 + 5, height / 64);
    }
}

function DrawStrings(stringsSizeArray, context, width, height) {
    let stringsAmount = stringsSizeArray.length;
    context.strokeStyle = "black";
    context.fillStyle = "white";
    let stringDistance = (width - width / 5) / (stringsAmount -1);
    let stringPosition = width / 10;
    for (let i = 0; i < stringsAmount; i++) {
        context.strokeRect(stringPosition, (height / 16) + 1, stringsSizeArray[i], height);
        context.fillRect(stringPosition, (height / 16) + 1, stringsSizeArray[i], height);    
        stringPosition += stringDistance;
    }
}

function SetAllStringsOpen(stringAmount) {
    markedFrets = [];
    for (let i = 0; i < stringAmount; i++) {
        markedFrets[i] = 0;
    }
}

function DrawFretMarkers(stringsAmount, context, width, height) {
    let openStringMarkerHeight = height / 24;
    let stringPosition = width / 10 - 2;
    let stringDistance = (width - width / 5) / (stringsAmount - 1);
    context.font = "bold 14px Arial";
    context.fillStyle = "black";
    for (let i = 0; i < stringsAmount; i++) {
        if (markedFrets[i] == 0) {
            context.fillText("O", stringPosition - i, openStringMarkerHeight);
        } else if (markedFrets[i] == -1) {
            context.fillText("X", stringPosition - i, openStringMarkerHeight);
        } else {
            context.beginPath();
            context.arc(stringPosition, (height / 16) + (((height - height / 8) / stringsAmount)+5) * markedFrets[i], width / 20, 0, 2 * Math.PI, false);
            context.fillStyle = 'black';
            context.fill();
        }
        stringPosition += stringDistance;
    }
}

function SaveChord() {
    let chordName = $("#chord-name").val();
    let userChords = JSON.parse(window.localStorage.getItem("userChords"));
    if (userChords == null) {
        userChords = {};
    }
    userChords[chordName] = markedFrets;
    window.localStorage.setItem("userChords", JSON.stringify(userChords));
}