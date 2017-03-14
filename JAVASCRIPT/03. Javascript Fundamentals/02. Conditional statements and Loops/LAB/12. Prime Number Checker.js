function primeNumberCheck(n) {
    let prime = true;

    if (n < 2) {
        prime = false;
    }
    else {
        for (let i = 2; i < Math.sqrt(n); i++) {
            if (n % i == 0) {
                prime = false;
            }
        }
       

    }
    if (prime == false) {
        console.log('false');
    }
    else {
        console.log('true');
    }
}