import { User } from "./User";
import { TranslatedDto } from "./translate/TranslatedDto";

export class DrugCategoryDto {
  translations: TranslatedDto[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
