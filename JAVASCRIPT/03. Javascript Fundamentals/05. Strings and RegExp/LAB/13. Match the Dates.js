function tesst(input) {
    let result =[];
    let text = input.join(' ');
    let pattern = /\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g;
    let reggex = new RegExp(pattern, 'g');
    let match = reggex.exec(text);

   while (match = pattern.exec(text)){
        console.log(`${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`);


   }

}