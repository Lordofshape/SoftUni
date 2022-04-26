function Sum(num1,num2,operator){
    let result;
    if (operator === '*') {
        result = num1 * num2;
    }
    else if(operator === '/'){
        result = num1 / num2;
    }
    else if(operator === '+'){
        result = num1 + num2;
    }
    else if(operator === '-'){
        result = num1 - num2;
    }
    else if(operator === '%'){
        result = num1 % num2;
    }
    else{
        result = num1 ** num2;
    }
    return result;
}