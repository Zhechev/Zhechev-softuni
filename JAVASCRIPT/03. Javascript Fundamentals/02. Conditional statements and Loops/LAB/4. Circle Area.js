function test([r]) {

    [r] = [r].map(Number);
    let area = Math.PI * r * r;
    console.log(area);
    area = Math.round(area * 100) / 100;
    console.log(area);
}
