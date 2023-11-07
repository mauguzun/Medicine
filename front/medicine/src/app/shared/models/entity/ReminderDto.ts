export class ReminderDto {
    dosingFrequencyReminders: DosingFrequencyReminderDto[];
    timeInUtc: string;
    title: string;
    description: string; // Note the corrected spelling of "description"
    user: User;
    userId: number;
    id: number;
    createdAt: Date;
  }
  