function letterOccurencesInString(input) {
    let count = 0;

    let word = input[0];
    let letter = input[1]

    for (let i = 0; i <input[0].length; i++){
        if (word[i] == letter){
            count++;
        }
    }

    console.log(count)
}