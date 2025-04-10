def solution(bandage, health, attacks):
    heal_time = 0
    attack_idx = 0
    hp = health
    # 1초부터 11초까지
    for i in range(1, attacks[-1][0] + 1):
        # 어택 타이밍이면 어택하기
        if attack_idx < len(attacks) and i == attacks[attack_idx][0]:
            hp -= attacks[attack_idx][1]
            attack_idx += 1
            heal_time = 0
        # 아니면 붕대감기
        else:
            # 붕대감기 연속시전 성공
            if heal_time == bandage[0] - 1:
                hp += bandage[1]
                hp += bandage[2]
                heal_time = 0
            # 그냥 붕대감기
            else:
                hp += bandage[1]
                heal_time += 1

        if hp <= 0:
            return -1
        if hp > health:
            hp = health
        if attack_idx == len(attacks):
            return hp
    return hp

