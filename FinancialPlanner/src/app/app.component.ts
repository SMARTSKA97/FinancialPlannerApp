import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ImportsModule } from '../imports';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ImportsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'FinancialPlanner';
}
