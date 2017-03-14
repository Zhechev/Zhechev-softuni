function test(input) {
let output = input.map(Number).filter((a,b) => b % 2 == 1).map(a => a*2).reverse();

   console.log(output)
}