var primes = [2,]
var num = 3;
var isPrime = true;
while(num <= 100) {
	for(var i = 0; i < primes.length; i++) {
		if(num % primes[i] == 0) {
			isPrime = false;
			break;
		}
		else {
			continue;
		}
	}
    if (isPrime == true) {
        primes.push(num);
    }
    num++;
    isPrime = true;	
}
console.log(primes)