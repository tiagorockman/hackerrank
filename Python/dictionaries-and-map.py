# Enter your code here. Read input from STDIN. Print output to STDOUT
# input example
# 3
# sam 99912222
# tom 11122222
# harry 12299933
# sam
# edward
# harry

if __name__ == '__main__':
    n = int(input())
    name_numbers = [input().split() for _ in range(n)]
    print(name_numbers)
    phone_book = {k: v for k,v in name_numbers}
    print(phone_book)
    while True:
        try:
            name = input()
            if name in phone_book:
                print('%s=%s' % (name, phone_book[name]))
            else:
                print('Not found')
        except:
            break
