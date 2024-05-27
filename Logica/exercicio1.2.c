#include<stdio.h>
#include<math.h>

main(){
    float PI = 3.14159;
    float raio, area;

    scanf("%f", &raio);

    area = PI * (pow(raio, 2));

    printf("Area = %.4f", area);
}