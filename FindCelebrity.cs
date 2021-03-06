    Person findCelebrity(Person[] persons)//функция которая принимает массив людей и позвращает одного человека
    {
        int l = 0, r = persons.Length - 1;//r- длина массива -1
        while (l != r)
        {
            if (persons[l].knows(persons[r]))//человек под индексом l знает ли человека под индексом r
            {
                l++;//если да, значит человек не знаменитость и мы l увеличеваем на 1
            }
            else
            {
                r--;//если нет, то человек знаменитость и мы уменькаем r на единицу
            }
        }
        for (int i = 0; i < persons.Length; i++)//проверка по всему массиву
        {
            if (i != l && (!persons[i].knows(persons[l]) || persons[l].knows(persons[i])))//i не равно 1, или персона i не знаает персону l и персона l знает i
            {
                return null;//если не прошел проверки то возвращает 0
            }
        }
        return persons[l];// если прошел то возвращает l
    }