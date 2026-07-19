import { Component, input, model } from '@angular/core';
import { MatCheckboxModule } from '@angular/material/checkbox';

export interface TaskItem {
  description: string;
  completed: boolean;
}

@Component({
  selector: 'task',
  templateUrl: 'task.html',
  styleUrl: 'task.css',
  imports: [MatCheckboxModule],
})
export class TaskComponent {
  description = input('');
  isDone = model(false);

  toggleTask() {
    this.isDone.update((value) => !value);
  }
}
