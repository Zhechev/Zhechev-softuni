function test(arr) {
let matrix = arr.map(row => row.split(' ').map(Number));
    let max = -9999;
    for (var row = 0; row < matrix.length; row++) {

        for (var col = 0; col < arr[row].length; col++) {
            if (matrix[row][col] > max){
                max = matrix[row][col];
            }
        }
    }
    console.log(max);
}