function test([n]) {
    [n] = [n].map(Number);
    let line = '';

    for (let row = 0; row <= n; row++) {
        let line = '';
        for (let col = 1; col <= row; col++) {
            line+= '$'
        }
        console.log(line);
    }
}