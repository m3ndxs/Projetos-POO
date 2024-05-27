#include<stdio.h>
#include<math.h>

main(){
    float a, b, c, delta, raiz_1, raiz_2;

    scanf("%f %f %f", &a, &b, &c);

    if(a == 0){
        printf("Impossivel calcular");
    }

    delta = pow(b, 2) - (4 * a * c);

    if (delta < 0){
        printf("Impossivel calcular");
        
    }

    raiz_1 = (-b + sqrt(delta)) / (2 * a);
    raiz_2 = (-b - sqrt(delta)) / (2 * a);

    printf("\nX1 = %.5f", raiz_1);
    printf("\nX2 = %.5f", raiz_2);
}