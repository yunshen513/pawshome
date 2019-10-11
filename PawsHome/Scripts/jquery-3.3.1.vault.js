    var click = 0;
    function wys() {
        click += 1;
        if (click === 13) {
            alert("Congratulations! You found me!");
            document.getElementById("home").innerHTML += '<audio style="display:none" autoplay loop><source src="http://music.163.com/song/media/outer/url?id=486100422.mp3" type="audio/mpeg"></audio>';
            click = 0;
    }
}
