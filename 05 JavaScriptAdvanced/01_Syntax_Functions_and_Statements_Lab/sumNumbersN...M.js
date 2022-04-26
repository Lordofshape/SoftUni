function sumNumbers(num1,num2){
    var firstNumber = Number(num1);
    var secondNumber = Number(num2);
    let sum = 0;
    for (let i = firstNumber; i <= secondNumber; i++) {
        sum += Number(i);     
    }
    return sum;
}