import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DisplayInfo } from '../display-info';
import { DisplayInfoService } from '../display-info.service';

@Component({
  selector: 'app-display-by-id',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './display-by-id.component.html',
  styleUrl: './display-by-id.component.css'
})
export class DisplayByIdComponent {

  data: DisplayInfo[] = [];
  selectedData: DisplayInfo | null = null;
  selectedId: number = 0;

  constructor(private displayInfoS: DisplayInfoService) { }

  ngOnInit(): void {
    // Fetch all records on component load
    this.displayInfoS.getInfo().subscribe((data: DisplayInfo[]) => {
      this.data = data;
    });
  }

  onSelect(id: number): void {
    // Fetch and display data for the selected ID
    this.displayInfoS.getDataById(id).subscribe((data: DisplayInfo) => {
      this.selectedData = data;
    });
  }


}
