import { Routes } from '@angular/router';
import { Homepage } from './features/homepage/homepage';
import { TaskList } from './features/task-list/task-list';

export const routes: Routes = [
  { path: '', component: Homepage },
  { path: 'todo', component: TaskList },
];
