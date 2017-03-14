function test([a,b,c]) {
    [a,b,c] = [a,b,c].map(Number);

    if (a > b && a > c){
        console.log(a);
    }
    else if (b > a && b > c){
        console.log(b);
    }
    else {
        console.log(c);
    }
}