var position1 = ["good1", 2];
var position2 = ["good2", 1];
var position3 = ["good3", 4];
var position4 = ["good4", 6];

var basket = [position1, position2, position3, position4];

function countBasketPrice(basket) {
	var goodsCount = 0;
	for	(var i = 0; i < basket.length; i++) {
		goodsCount += basket[i][1];
	}
	return goodsCount;
}

var countGoods = countBasketPrice(basket);
console.log(countGoods);