#include<stdio.h>

main(){
    int cod_menu, qtd;
    float valor_total;

    printf("--------------------- CARDAPIO --------------------- ");
    printf("\nCODIGO            ESPECIFICACAO             PRECO");
    printf("\n   1             Cachorro Quente             4.00");
    printf("\n   2                X-Salada                 4.50");
    printf("\n   3                X-Bacon                  5.00");
    printf("\n   4             Torrada Simples             2.00");
    printf("\n   5               Refrigerante              1.50");

    printf("\n\nFaca seu pedido informando o codigo do produto e quantidade: ");
    scanf("%d %d", &cod_menu, &qtd);

    switch(cod_menu)
    {
    case 1:
        valor_total = 4.00 * qtd;
        printf("Total: R$ %.2f", valor_total);
        break;
    case 2:
        valor_total = 4.50 * qtd;
        printf("Total: R$ %.2f", valor_total);
        break;
    case 3:
        valor_total = 5.00 * qtd;
        printf("Total: R$ %.2f", valor_total);
        break;
    case 4:
        valor_total = 2.00 * qtd;
        printf("Total: R$ %.2f", valor_total);
        break;
    case 5:
        valor_total = 1.50 * qtd;
        printf("Total: R$ %.2f", valor_total);
        break;
    
    default:
        printf("\nCodigo Invalido");
        break;
    }
}