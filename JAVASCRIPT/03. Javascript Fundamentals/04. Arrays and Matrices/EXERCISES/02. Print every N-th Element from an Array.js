function test(arr) {
    arr.map(Number);
    let n = Number(arr[arr.length - 1]);
    arr.pop();
    let result = [];

    for (let i = 0; i < arr.length; i+=n) {
        result.push(arr[i]);
    }
    console.log(result.join('\n'))
}