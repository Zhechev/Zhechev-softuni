function areaTriangle([a, b, c]) {
    [a,b,c] = [a,b,c].map(Number);
    let halfP = (a + b + c)/2;
    let area = Math.sqrt(halfP*(halfP-a)*(halfP-b)*(halfP-c));
    console.log(area)
}