function test(input) {
let arr = input.join('');


for(let element in arr){
    console.log(`str[${element}] -> ${arr[element]}`)
}
}