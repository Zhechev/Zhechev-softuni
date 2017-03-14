function test([n]) {
    [n] = [n].map(Number);

    for (let i = 1; i <= n; i++) {
        if (i % 2 == 1) {
            console.log(i);
        }
    }
}