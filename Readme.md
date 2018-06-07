﻿# Состав решения

## TextAnalyzerShared

Shared project, содержащий необходимые элементы для разработки кастомных метрик.

* Core.ITextMetric - интерфейс, который должен имплементировать класс текстовой метрики.
* Core.BaseTextMertic - абстрактный суперкласс для текстовых метрик. При наследовании необходимо, кроме всего прочего, реализовать метод Calculate(), который выполняет логику анализа.
* Metrics.* - несколько простых текстовых метрик для примера.
* Utils.Starter.GetAllMetrics() - статический метод, возвращающий список всех текстовых метрик в проекте, имплементирующих Core.ITextMetric.
* Utils.Starter.RunAnalyzer(txt) - статический метод, выполняющий анализ текста по всем метрикам в проекте.

## TextAnalyzerConsole

Простейшее консольное приложение для анализа текста из файла с использованием функциональности TextAnalyzerShared.
Параметры запуска:
* /h - список всех используемых текстовых метрик.
* /f:текстовый_файл - путь к тектовому файлу, который будет проанализирован.

## TextAnalyzerWeb

Простейшее web-приложение для анализа текста из поля ввода с использованием функциональности TextAnalyzerShared.

