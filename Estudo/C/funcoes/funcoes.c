#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>

void TestePrint(void);
int soma(int x, int y);

int main(int argc, char *argv[]) {
  TestePrint();
  printf("%d\n", soma(10, 5));
}

void TestePrint(void) { printf("Eu sou incrivel e um bom estudante\n"); }

int soma(int x, int y) { return x + y; }
