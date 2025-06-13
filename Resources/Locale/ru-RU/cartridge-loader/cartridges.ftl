device-pda-slot-component-slot-name-cartridge = Картридж
default-program-name = Программа
notekeeper-program-name = Заметки
news-read-program-name = Новости станции
crew-manifest-program-name = Манифест экипажа
crew-manifest-cartridge-loading = Загрузка...
net-probe-program-name = Зонд сетей
net-probe-scan = Просканирован { $device }!
net-probe-label-name = Название
net-probe-label-address = Адрес
net-probe-label-frequency = Частота
net-probe-label-network = Сеть
log-probe-program-name = Зонд логов
log-probe-scan = Загружены логи устройства { $device }!
log-probe-label-time = Время
log-probe-label-accessor = Использовано:
log-probe-label-number = #
nano-task-program-name = Нанозадача
log-probe-print-button = Печатные журналы
log-probe-printout-device = Scanned Device: {$name}
log-probe-printout-header = Последние журналы:
log-probe-printout-entry = #{$number} / {$time} / {$accessor}
astro-nav-program-name = Астронав
med-tek-program-name = MedTek

# NanoTask cartridge
nano-task-ui-heading-high-priority-tasks = { $amount ->
        [zero] No High Priority Tasks
        [one] 1 High Priority Task
       *[other] {$amount} High Priority Tasks
    }
nano-task-ui-heading-medium-priority-tasks = { $amount ->
        [zero] No Medium Priority Tasks
        [one] 1 Medium Priority Task
       *[other] {$amount} Medium Priority Tasks
    }
nano-task-ui-heading-low-priority-tasks = { $amount ->
        [zero] No Low Priority Tasks
        [one] 1 Low Priority Task
       *[other] {$amount} Low Priority Tasks
    }
nano-task-ui-done = Сделанный
nano-task-ui-revert-done = Отменить
nano-task-ui-priority-low = Низкий
nano-task-ui-priority-medium = Середина
nano-task-ui-priority-high = Высокий
nano-task-ui-cancel = Отмена
nano-task-ui-print = Печать
nano-task-ui-delete = Удалить
nano-task-ui-save = Сохранять
nano-task-ui-new-task = Новая задача
nano-task-ui-description-label = Описание:
nano-task-ui-description-placeholder = Получите что -нибудь важное
nano-task-ui-requester-label = Запрашивающая:
nano-task-ui-requester-placeholder = Джон Нанотразен
nano-task-ui-item-title = Редактировать задачу
nano-task-printed-description = Description: {$description}
nano-task-printed-requester = Requester: {$requester}
nano-task-printed-high-priority = Приоритет: высокий
nano-task-printed-medium-priority = Приоритет: средний
nano-task-printed-low-priority = Priority: Low

# Wanted list cartridge
wanted-list-program-name = Разыскиваемый список
wanted-list-label-no-records = Все в порядке, ковбой
wanted-list-search-placeholder = Поиск по имени и статусу
wanted-list-age-label = [color=darkgray]Age:[/color] [color=white]{$age}[/color]
wanted-list-job-label = [color=darkgray]Job:[/color] [color=white]{$job}[/color]
wanted-list-species-label = [color=darkgray]Species:[/color] [color=white]{$species}[/color]
wanted-list-gender-label = [color=darkgray]Gender:[/color] [color=white]{$gender}[/color]
wanted-list-reason-label = [color=darkgray]Reason:[/color] [color=white]{$reason}[/color]
wanted-list-unknown-reason-label = неизвестная причина
wanted-list-initiator-label = [color=darkgray]Initiator:[/color] [color=white]{$initiator}[/color]
wanted-list-unknown-initiator-label = неизвестный инициатор
wanted-list-status-label = [color=darkgray]status:[/color] {$status ->
        [suspected] [color=yellow]suspected[/color]
        [wanted] [color=red]wanted[/color]
        [detained] [color=#b18644]detained[/color]
        [paroled] [color=green]paroled[/color]
        [discharged] [color=green]discharged[/color]
        *[other] none
    }
wanted-list-history-table-time-col = Время
wanted-list-history-table-reason-col = Преступление
wanted-list-history-table-initiator-col = Инициатор
