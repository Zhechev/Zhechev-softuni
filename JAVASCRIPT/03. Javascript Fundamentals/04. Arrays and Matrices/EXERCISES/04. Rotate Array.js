function test(arr) {
    let count = Number(arr[arr.length-1]);
    arr.pop();
    let final = count % arr.length;


    for (let i = 1; i <= final; i++) {
        arr.unshift(arr[arr.length - 1])
        arr.pop();
    }


    console.log(arr.join(' '));

}