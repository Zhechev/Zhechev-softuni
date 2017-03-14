function distanceIn3D([x1, y1, z1, x2, y2, z2]) {

    var d = Math.sqrt( (x2-=x1)*x2 + (y2-=y1)*y2 + (z2-=z1)*z2 );

    console.log(d);
}
