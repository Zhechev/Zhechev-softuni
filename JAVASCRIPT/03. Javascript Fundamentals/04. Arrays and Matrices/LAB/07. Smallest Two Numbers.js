function test(input) {
let output = input.map(Number).sort((a,b) => a - b).slice(0,2);

   console.log(output)
}