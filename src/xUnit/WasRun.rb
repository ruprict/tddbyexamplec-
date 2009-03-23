class WasRun
	attr_accessor :wasRun
	def initialize(methodName)
		@wasRun=false
		@methodName=methodName	
	end
	def run
		send(@methodName)
	end
	
	def testMethod
		@wasRun=true
	end
	
end
