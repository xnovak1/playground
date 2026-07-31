import { Component, computed, signal } from '@angular/core';
import { TaskComponent, TaskItem } from '../task/task';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'task-list',
  templateUrl: './task-list.html',
  styleUrl: './task-list.css',
  imports: [TaskComponent, MatButtonModule, FormsModule],
})
export class TaskList {
  tasks = signal<TaskItem[]>([]);
  description = signal('');
  canAddTask = computed(() => this.description().trim().length > 0);
  taskCount = computed(() => this.tasks().length);

  addTask(): void {
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

  deleteTask(index: number): void {
    const updatedTasks = [...this.tasks()];
    updatedTasks.splice(index, 1);
    this.tasks.set(updatedTasks);
  }
}
