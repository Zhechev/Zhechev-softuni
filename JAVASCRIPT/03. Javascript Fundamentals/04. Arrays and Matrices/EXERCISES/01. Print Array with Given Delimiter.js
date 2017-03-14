function test(arr) {
    let del = arr[arr.length - 1];
    arr.pop();
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        if (i == arr.length-1){
            result+= arr[i];
        }
        else {
            result += arr[i] + del;
        }
    }
    console.log(result)
}