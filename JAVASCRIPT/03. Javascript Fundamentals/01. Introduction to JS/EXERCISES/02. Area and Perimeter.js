function areaAndPerimeter([a, b]) {
    [a,b] = [a,b].map(Number);

    console.log((a*b).toFixed(2));
    console.log(2*(a+b).toFixed(2))
}