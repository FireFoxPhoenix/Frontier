roles-antag-survivor-name = Survivor
# It's a Halo reference
roles-antag-survivor-objective = Текущая цель: выжить
survivor-role-greeting = You are a Survivor.
    Above all you need to make it back to CentComm alive.
    Collect as much firepower as needed to guarantee your survival.
    Trust no one.
survivor-round-end-dead-count = {
    $deadCount ->
        [one] [color=red]{$deadCount}[/color] survivor died.
        *[other] [color=red]{$deadCount}[/color] survivors died.
}
survivor-round-end-alive-count = {
    $aliveCount ->
        [one] [color=yellow]{$aliveCount}[/color] survivor was marooned on the station.
        *[other] [color=yellow]{$aliveCount}[/color] survivors were marooned on the station.
}
survivor-round-end-alive-on-shuttle-count = {
    $aliveCount ->
        [one] [color=green]{$aliveCount}[/color] survivor made it out alive.
        *[other] [color=green]{$aliveCount}[/color] survivors made it out alive.
}

## Wizard
objective-issuer-swf = [color=turquoise]The Space Wizards Federation[/color]
wizard-title = Волшебник
wizard-description = На станции есть волшебник! Вы никогда не знаете, что они могут сделать.
roles-antag-wizard-name = Волшебник
roles-antag-wizard-objective = Обучите им урок, который они никогда не забудут.
wizard-role-greeting = У тебя волшебник!
    Между Федерацией космических волшебников и нанотразеном была напряженность.
    Таким образом, вы были выбраны Федерацией космических волшебников для посещения станции.
    Дайте им хорошую демонстрацию ваших способностей.
    То, что вы делаете, зависит от вас, просто помните, что космические волшебники хотят, чтобы вы зажили это.
wizard-round-end-name = wizard

## TODO: Wizard Apprentice (Coming sometime post-wizard release)
