"use strict";
var platform_browser_dynamic_1 = require('@angular/platform-browser-dynamic');
var app_service_todolist_1 = require('./services/app.service.todolist');
var http_1 = require('@angular/http');
var todolist_component_1 = require('./components/todolist/todolist.component');
var donate_component_1 = require('./components/donate/donate.component');
var app_service_donate_1 = require('./services/app.service.donate');
//enableProdMode();
platform_browser_dynamic_1.bootstrap(todolist_component_1.TodoListComponent, [http_1.HTTP_PROVIDERS, app_service_todolist_1.AppServiceTodoList, donate_component_1.DonateComponent, app_service_donate_1.AppServiceDonate]);
//bootstrap(DonateComponent, [HTTP_PROVIDERS, AppServiceDonate]); 
//# sourceMappingURL=boottodolist.js.map