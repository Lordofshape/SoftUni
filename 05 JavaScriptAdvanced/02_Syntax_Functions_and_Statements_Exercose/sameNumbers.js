function solve(number){
    const stringNumber = number.toString();
    let flag = true;
    let sum = 0;
    sum += Number(stringNumber[0]);
    for (let i = 1; i < stringNumber.length; i++) {
        if (stringNumber[i-1]!==stringNumber[i]) {
            flag = false;
        }
        sum += Number(stringNumber[i]);   
    }
    console.log(flag);
    console.log(sum);
}

solve(2222);