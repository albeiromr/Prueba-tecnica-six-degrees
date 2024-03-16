import { ErrorModel } from "./error-model"
import { UserModel } from "./user.model"

export interface ApiResponseModel {
    data : UserModel[];
    success: boolean;
    error: ErrorModel | null;
}