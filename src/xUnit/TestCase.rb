class TestCase
	attr_accessor :wasRun
	attr_accessor :wasSetup
	def initialize(methodName)
		@wasRun=false
		@methodName=methodName	
	end
	
	def setUp
		@wasSetup=true
		puts "fart"
	end
	
	def run
		setUp
		send(@methodName)
	end
	def assert(condition)
		if (!condition)
			puts "ERROR"
		else
			puts "OK"
		end
	end
end
