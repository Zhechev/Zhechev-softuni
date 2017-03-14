function imperialUnits([n]) {


let a = n / 12;
let b = n % 12;


    console.log(Math.floor(Number(a)) + '\'' + '-' + b + '"');
}