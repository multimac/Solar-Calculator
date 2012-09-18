package validation;

public class Validator {
		
	private Validator(){
		
	}
	
	static public boolean IsInteger(String str){
		try {
			Integer.parseInt(str);
			return true;
		}
		catch (Exception e) {
			return false;
		}
	}
	
	static public boolean IsDouble(String str){
		try {
			Double.parseDouble(str);
			return true;
		}
		catch (Exception e) {
			return false;
		}
	}
	
}
