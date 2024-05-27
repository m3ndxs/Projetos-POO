#include<stdio.h>
#include<conio.h>

main(){
    int cod_peca1, cod_peca2, qtd_peca1, qtd_peca2;
    float valor_peca1, valor_peca2, valor_total;

    scanf("%d %d %f", &cod_peca1, &qtd_peca1, &valor_peca1);
    scanf("%d %d %f", &cod_peca2, &qtd_peca2, &valor_peca2);

    valor_total = (qtd_peca1 * valor_peca1) + (qtd_peca2 * valor_peca2);

    printf("Valor a pagar: R$ %.2f", valor_total);
}