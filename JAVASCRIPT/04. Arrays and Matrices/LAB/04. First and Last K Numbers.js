function test(arr) {
let k = arr[0]
    arr.shift();

    let left = arr.slice(0,k);
    let right = arr.slice(arr.length-k, arr.length)
    console.log(left);
    console.log(right);
}
