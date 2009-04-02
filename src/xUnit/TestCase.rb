require 'TestResult'
class TestCase
	attr_accessor :log
	
	def initialize(methodName)
		@methodName=methodName	
	end
	
	def setUp
		@log = "setUp "
	end
	def tearDown
		puts "*** in tearDown"
		@log+="tearDown"
	end
	def run
		setUp
		send(@methodName)
		tearDown
		return TestResult.new
	end
	def assert(condition)
		if (!condition)
			puts "ERROR"
		else
			puts "OK"
		end
	end
end
