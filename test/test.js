/// <reference path="../out/code.js" />
test("will add 5 to number", function () {
    var res = mathLib.add5(10);
    equal(res, 15, "should add 5");
});
