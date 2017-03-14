function colorize() {
    let j = 1;
    for (let tr of document.querySelectorAll('table tr')){

        if (j % 2 == 0) {
            tr.style.background = "Teal";
        }
        j++;
    }

}
