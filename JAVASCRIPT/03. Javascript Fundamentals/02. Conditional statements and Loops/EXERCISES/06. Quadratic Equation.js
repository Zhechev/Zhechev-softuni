function quadraticEquation([a,b,c]) {
    [a,b,c] = [a,b,c].map(Number);
    let d = b * b - 4 * a * c;
    let x1 = 0;
    let x2 = 0;

    if (d > 0){
        x1= -b/2/a+Math.pow(Math.pow(b,2)-4*a*c,0.5)/2/a;
        x2= -b/2/a-Math.pow(Math.pow(b,2)-4*a*c,0.5)/2/a;
        if (x1 > x2){
            console.log(x2);
            console.log(x1);
        }
        else {
            console.log(x1);
            console.log(x2);
        }

    }
    else if (d == 0){
        console.log(-b / (2*a));
    }
    else {
        console.log('No');
    }
}