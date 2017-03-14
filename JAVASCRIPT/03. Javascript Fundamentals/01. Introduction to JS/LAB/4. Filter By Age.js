function countLetters([minAge, nameA, ageA, nameB, ageB]) {
    let playerA = {name:nameA, age:Number(ageA)};
    let playerB = {name:nameB, age:Number(ageB)};

    if(playerA.age >= minAge){
        console.log(playerA);
    }
    if(playerB.age >= minAge) {
        console.log(playerB);
    }
}

