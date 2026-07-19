import { Component, computed, signal } from '@angular/core';
import { TaskComponent, TaskItem } from '../task/task';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'task-list',
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
  imports: [TaskComponent, MatButtonModule],
})
export class TaskList {
  tasks = signal<TaskItem[]>([]);
  description = signal('');
  canAddTask = computed(() => this.description().trim().length > 0);
  taskCount = computed(() => this.tasks().length);

  addTask() {
    const description = this.description().trim();

    if (!description) {
      return;
    }

    const task: TaskItem = {
      description,
      completed: false,
    };

    this.tasks.set([...this.tasks(), task]);
    this.description.set('');
  }
}
