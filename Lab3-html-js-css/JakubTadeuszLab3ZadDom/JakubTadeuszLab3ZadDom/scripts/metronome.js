
let barsAmount = 0;
let playedBeat = 1;
let lastBeat = 1;
let metronomeInterval;
let BPM
let defaultDrum = document.createElement('audio');
defaultDrum.setAttribute('src', 'sounds/drum1.wav');
let alternativeDrum = document.createElement('audio');
alternativeDrum.setAttribute('src', 'sounds/drum2.wav');
let beatDrums = [];

function StartMetronome() {
    $("#metronome-button").attr("onclick", "StopMetronome()");
    $("#metronome-button").text("Stop");
    BPM = $("#metronome-bpm").val();
    metronomeInterval = setInterval(PlayNextBeat, 60000 / BPM);
}

function StopMetronome() {
    $("#metronome-button").attr("onclick", "StartMetronome()");
    $("#metronome-button").text("Start");
    clearInterval(metronomeInterval);
    playedBeat = 1;
}

function PlayNextBeat() {
    if (beatDrums[playedBeat - 1]) {
        alternativeDrum.currentTime = 0;
        alternativeDrum.play();
    } else {
        defaultDrum.currentTime = 0;
        defaultDrum.play();
    }
    $("#beat" + playedBeat).css("background-color", "#fc0e0e");
    setTimeout(function(){ StopBeat(lastBeat); }, (60000 / (2 * BPM)));
    playedBeat++;
    lastBeat = playedBeat - 1;
    if (playedBeat > barsAmount) {
        lastBeat = barsAmount;
        playedBeat = 1;
    }
}

function StopBeat(beatNumber) {
    if (beatDrums[beatNumber - 1]) {
        $("#beat" + (beatNumber)).css("background-color", "#3a4352");
    } else {
        $("#beat" + (beatNumber)).css("background-color", "#232228");
    }
}

function AddBeat(drum) {
    barsAmount++;
    $("#beat-buttons-group").append("<button id='beat" + barsAmount + "' class='beat-button' onclick = 'ChangeBeatDrum(" + barsAmount + ")'></button>");
    if (drum) {
        $("#beat" + (barsAmount)).css("background-color", "#3a4352");
    }
    beatDrums[barsAmount-1] = drum;
}

function RemoveBeat() {
    if (barsAmount > 0) {
        $("#beat" + barsAmount).remove();
        barsAmount--;
    }
}

function ClearBeats() {
    beatDrums = [];
    for (let i = 0; i < barsAmount; i++) {
        beatDrums[i] = false;
    }
}

function ChangeBeatDrum(beat) {
    beatDrums[beat - 1] = !beatDrums[beat - 1];
    if (beatDrums[beat - 1]) {
        $("#beat" + (beat)).css("background-color", "#3a4352");
    } else {
        $("#beat" + (beat)).css("background-color", "#232228");
    }
}

function SetupMetronome() {
    let metronomeArray = JSON.parse(window.sessionStorage.getItem("metronomeArray"));
    if (metronomeArray != null) {
        for (let i = 0; i < metronomeArray.length; i++) {
            AddBeat(metronomeArray[i]);
        }
    } else {
        AddBeat(0);
        AddBeat(0);
        AddBeat(0);
    }
}