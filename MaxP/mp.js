function desinfectanteLiquido(litros,efectivo) {
    if (litros > 500) {
        precio=10;
    } {if (litros <= 500 && litros > 200) {
        precio=15;
    } {if (litros >=51 && litros <=200) {
        precio=20;
    } {if (litros<=50 && litros >0) {
        precio=25
    }}}}
    PF=precio*litros
    if (efectivo==1) {
        PF=(precio*litros)*0.9
    }
    console.log(PF)
}
desinfectanteLiquido(501,1)



function myPC(micro,ram,extDisk) {
    if (micro==1&&ram==1) {
        combo=800;
    }
    if (micro==2&&ram==1) {
        combo=900;
    }
    if (micro==3&&ram==1) {
        combo=1200;
    }
    if (micro==1&&ram==2) {
        combo=900;
    }
    if (micro==2&&ram==2) {
        combo=1000;
    }
    if (micro==3&&ram==2) {
        combo=1400;
    }
    if (micro==1&&ram==3) {
        combo=1000;
    }
    if (micro==2&&ram==3) {
        combo=1400;
    }
    if (micro==3&&ram==3) {
        combo=2000;
    }
    PF=combo
    if (extDisk==1) {
        PF=combo+300
    }
    console.log('USD:'+PF)
}myPC(3,3,1)

function mayorDeLosDiez(num) {
M=0
for (x=0;x<10;x++) {
    if (num>M) {
        M=num
    }
}
console.log(M)
}
