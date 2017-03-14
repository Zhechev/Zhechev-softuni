function rounding([number, point]) {

    [number,point] = [number,point].map(Number);

    let pointt = point;
    if (pointt > 15){
        pointt = 15;
    }


    console.log(Number(number.toFixed(pointt)));
}