message = input().lower()

alph = "abcdefghijklmnopqrstuvwxyz"

for c in message:
    print(alph[-(alph.find(c) + 1)] if c != " "
          else " ", end = "")
