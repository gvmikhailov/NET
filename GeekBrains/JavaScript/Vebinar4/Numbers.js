function getRandomInt(max) {
  return Math.floor(Math.random() * max);
}

var number = getRandomInt(2000);
var obj = {};
console.log(number);

function getRankObject(intNum) {
	var rankObject = {};
	var res = [];
	if(intNum > 999) {
		console.log("Введенное число больше 999");
		return rankObject;		
	}
	else {
		var baseStart = 10;
		var currentNum = intNum;
		do {
			var baseShiftedNum = Math.floor(currentNum / baseStart);
			var diff = currentNum - baseShiftedNum * baseStart;
			res.unshift(diff);
			currentNum = baseShiftedNum;
		} while (currentNum > 0)
	}

	switch(res.length) {
		case 1 : 
			return rankObject = {
				["Единицы"]: res[0],
				["Десятки"]: 0,
				["Сотни"]: 0,
			};
		case 2 : 
			return rankObject = {
				["Единицы"]: res[1],
				["Десятки"]: res[0],
				["Сотни"]: 0,
			};
		case 3 :
			return rankObject = {
				["Единицы"]: res[2],
				["Десятки"]: res[1],
				["Сотни"]: res[0],
			};
	}	
}

obj = getRankObject(number);

console.log(obj["Единицы"]);
console.log(obj["Десятки"]);
console.log(obj["Сотни"]);
