var position1 = {Id: 34 ,Good: "Good1", Count: 5};
var position2 = {Id: 52 ,Good: "Good2", Count: 1};
var position3 = {Id: 72 ,Good: "Good3", Count: 13};
var position4 = {Id: 18 ,Good: "Good4", Count: 3};

// Можно и тут в объект положить, но это лишнее, лучше работать с общими коллекциями
var basket = [position1, position2, position3, position4];

function countBasketPrice(basket) {
	var goodsCount = 0;
	for	(var i = 0; i < basket.length; i++) {
		goodsCount += basket[i].Count;
	}
	return goodsCount;
}

var countGoods = countBasketPrice(basket);
console.log(countGoods);